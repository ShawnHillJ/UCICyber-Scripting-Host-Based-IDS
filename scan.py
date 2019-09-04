#!/usr/bin/python

import os
import sys
import time
from os import path

cmd='lsof -Pni'
# command/pid/user/fd/type/device/size\off/node/name
header=['command', 'pid', 
'user', 'fd', 
'ip type', 'device', 
'size/off', 'node', 
'network','state'
]
help_info = '''
The scan python script takes a file as input and block all the connection aside from
process/services/programs those are listed in the file. The default background scan
interval is set to be 5 seconds.

USAGE:   
python scan.py [filename]
'''
blocked=[]
interval=5


def scan():
	log=[]
	raw_data=os.popen(cmd).read().split('\n')
	for line in raw_data[1:]:
		if len(line)==0:
			continue
		d={}
		i=0
		sp=line.split(' ')
		# print(sp)
		for item in sp:
			if len(item)>0:
				d[header[i]]=item
				i+=1
		log.append(d)
	return log


def block_connection(path):
	try:
		allowed_proc=open(path, 'r')
	except:
		print('invalid path')
		sys.exit()
	allowed_cmd=allowed_proc.read().split('\n')
	cur_log=scan()
	for item in cur_log:
		if item['command'] not in allowed_cmd:
			os.popen('kill %s'%item['pid'])
			blocked.append(item)
			print('block process: {}'.format(item))
	allowed_proc.close()


def allow(cmd):
	allowed_proc=open(allowed_path ,'a')
	allowed_proc.write(cmd+'\n')


def run(path):
	while True:
		block_connection(path)
		time.sleep(interval)

def hasPerm():
	return os.popen('whoami').read().startswith('root')




if __name__ == '__main__':
	if hasPerm():
		if len(sys.argv)==1:
			print('specify a file which contains permitted process')
			sys.exit()
		else:
			if 'help' in sys.argv[1]:
				print(help_info)
			else:
				file_name = sys.argv[1]
				path = os.path.join(os.getcwd(), file_name)
				run(path)
	else:
		print('you dont have permission to run this script')
		sys.exit()