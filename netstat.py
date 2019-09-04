#!/usr/bin/python

import os
from os import path
import sys
import subprocess
import time
import re
from datetime import datetime



help_info='''
Netstat:
This script uses Linux netstat command and create two log text files and two csv files
for connection and socket status.

Usage:
	-d [start date, end date]  Specify a date range and will return a log of connection
							   and socket usage.
	-v [time interval]         Set the time interval for updates, default 30 seconds.
	-r                         Remove all current existing log files.
	--help                     Displays more information about this script, will not 
	                           execute the script.

This script only takes one flag at a time. Multiple flags will not work, sorry not sorry.
'''


class log_state:


	def __init__(self):

		self.log=[]
		self.conn=[]
		self.sock=[]


	def record(self):

		os.popen("netstat -p > log.txt").read()
		with open("log.txt", "r") as handle:
			line=0
			for i in handle.readlines():
				self.log.append(i.strip("\n"))
		self.log=self.log[2:]


	def seperate(self):

		while self.log:
			line=self.log.pop()
			if 'Active' in line:
				break
			else:
				self.sock.append(line)
		while self.log:
			self.conn.append(self.log.pop())


	def start(self):
		self.record()
		self.seperate()



def run(interval=30):
	print('For more info about this script, use --help.')
	conn_f=open("connection_log.txt", 'a+')
	sock_f=open("socket_log.txt", 'a+')
	conn_csv=open('connection.csv', 'a+')
	sock_csv=open('socket.csv', 'a+')
	initial=log_state()
	initial.start()
	conn=initial.conn
	sock=initial.sock
	if len(conn_f.read())==0:
		conn_f.write("Changed connections:\n")
		conn_f.write("Status   Date                 Proto Recv-Q Send-Q Local Address           Foreign Address         State       PID/Program name\n")
	if len(sock_f.read())==0:
		sock_f.write("Changed socket usage:\n")
		sock_f.write("Status   Date                 Proto RefCnt Flags       Type       State         I-Node   PID/Program name     Path\n")
	if len(conn_csv.read())==0:
		conn_csv.write('status,protocol,recv-q,send-q,local address,foreign address,state,pid/program name\n')
	if len(sock_csv.read())==0:
		sock_csv.write('status,protocol,refcnt,flags,type,state,i-node,pid/program name,path\n')
	
	while 1:

		temp=log_state()
		temp.start()
		new_conn=[]
		new_sock=[]
		closed_conn=[]
		closed_sock=[]
		for i in temp.conn:
			if i not in conn:
				new_conn.append(i)
		for i in conn:
			if i not in temp.conn:
				closed_conn.append(i)
		for i in temp.sock:
			if i not in sock:
				new_sock.append(i)
		for i in sock:
			if i not in temp.sock:
				closed_sock.append(i)	
		for i in new_conn:
			conn_f.write(" [+]     {:20s} {}\n".format(time.strftime("%H:%M:%S %m/%d/%Y"), i))
			conn_csv.write('new,'+','.join(i.split())+'\n')
		for i in closed_conn:
			conn_f.write(" [-]     {:20s} {}\n".format(time.strftime("%H:%M:%S %m/%d/%Y"), i))
			conn_csv.write('closed,'+','.join(i.split())+'\n')
		for i in new_sock:
			sock_f.write(" [+]     {:20s} {}\n".format(time.strftime("%H:%M:%S %m/%d/%Y"), i))
			sock_csv.write('new,'+format_sock_line(i)+'\n')
		for i in closed_sock:
			sock_f.write(" [-]     {:20s} {}\n".format(time.strftime("%H:%M:%S %m/%d/%Y"), i))
			sock_csv.write('closed,'+format_sock_line(i)+'\n')
		conn=temp.conn
		sock=temp.sock
		os.popen('clear')
		time.sleep(interval)

def format_sock_line(line):
	params = re.split('\s\s+', line)
	if len(params)==8:
		return ','.join(params)
	else:
		if len(params)==7:
			if params[4].isdigit():
				params.insert(4, '')
			else:
				params.append('')
		else:
			params.insert(4, '')
			params.append('')
		return ','.join(params)

# function to return log based on time interval provided

def sort_date():

	if (not os.path.exists(os.getcwd()+'/connection_log.txt')) and (not os.path.exists(os.getcwd()+'/socket_log.txt')):
		print('there is no log files to begin with, run the script first')
		sys.exit()
	try:
		year, mon, day=time.localtime()[:3]
		start_day=int(input('Enter start day (default today) :')) or time.localtime()[3]
		start_time=input('Enter start time (hr:min:sec, default 00:00:00)') or '00:00:00'
		end_day=int(input('Enter start day (default today) :')) or time.localtime()[3]
		end_time=input('Enter start time (hr:min:sec, default 23:59:59)') or '23:59:59'
		start_string='{}/{}/{} {}'.format(year, mon, start_day, start_time)
		end_string='{}/{}/{} {}'.format(year, mon, end_day, end_time)
		output(start_string, end_string)
		print('done')
		sys.exit()
	except:
		print('invalid input, try again.')
		sys.exit()



def output(start, end):

	start_d = datetime.strptime(start, "%d/%m/%Y %H:%M:%S")
	start_int=int(time.mktime(start_d.timetuple()))
	end_d = datetime.strptime(end, "%d/%m/%Y %H:%M:%S")
	end_int=int(time.mktime(end_d.timetuple()))

	temp_conn=open('connection_log.txt', 'r')
	temp_sock=open('socket_log.txt', 'r')
	conn_out=open('conn_out.txt', 'w')
	sock_out=open('sock_out.txt', 'w')
	conn_out.write('Status   Date                 Proto Recv-Q Send-Q Local Address           Foreign Address         State       PID/Program name\n')
	sock_out.write('Status   Date                 Proto RefCnt Flags       Type       State         I-Node   PID/Program name     Path\n')
	
	for line in temp_conn.readlines()[1:]:
		t_time=line[9:29].strip()
		d_time=datetime.strptime(t_time, "%H:%M:%S %m/%d/%Y")
		i_time=int(time.mktime(d_time.timetuple()))
		if i_time in range(start_int, end_int):
			conn_out.write(line)

	for line in temp_sock.readlines()[1:]:
		t_time=line[9:29].strip()
		d_time=datetime.strptime(t_time, "%H:%M:%S %m/%d/%Y")
		i_time=int(time.mktime(d_time.timetuple()))
		if i_time in range(start_int, end_int):
			sock_out.write(line)



def remove_logs():
	os.popen('rm connection_log.txt')
	os.popen('rm connection.csv')
	os.popen('rm socket_log.txt')
	os.popen('rm socket.csv')










if __name__=='__main__':

	if len(sys.argv)>1:
		
		if sys.argv[1]=='--help':
			print(help_info)
		if sys.argv[1]=='-v':
			try:
				itv = int(sys.argv[2])
				run(interval=int(itv))
			except:
				print('Excepted the parameter to be an integer. For more use --help')
		if sys.argv[1]=='-d':
			sort_date()
		if sys.argv[1]=='-r':
			remove_logs()

	else:
		run()


