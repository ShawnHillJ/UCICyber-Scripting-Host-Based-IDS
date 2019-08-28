#param(

# This script is for checking current logs that are set up to be recorded on the local machine
# It can also be used to check logs being recorded from the domain as well
# This script is able to set up the machine to record logs if logs are disabled or not properly
# configured alread.
# By default this script will return common logs that the machine is and is not recording
# It will also configure common logs to be configured.
# It can be supplied with certain logs using Event IDs if you would like to setup more customized logs
# 
# *What windows should this work on? What windows have built in wevtutil? that's mostly what this script runs on
# *I want to add the ability to tell you the significance of not having certain logs setup 

 
# Parameter guide 
# 
# 
# 
# 
# 


#to scan for local logs





#to show a list of common logs
#creates a windows table to view them
#need to implement the ability to supply it with a file
#and it uses that file to display a custom list of logs to show
function Show-commonlogs{

    $commonseclogs = New-Object system.Data.DataTable "Common Logs"

    $commonseclogs.Columns.add( (New-object system.Data.DataColumn "EventID"))
    $commonseclogs.Columns.Add((New-object system.Data.DataColumn "Description (security logs)"))
    
    
    #$commonseclogs.Columns.add( "EventID",tyDataColumn )
    #$commonseclogs.Columns.add("Description
    #$colID = New-Object system.Data.DataColumn "EventID"
    #$colDes = New-Object System.Data.DataColumn "Description
    #$commonseclogs.Columns.Add($colID)
    #$commonseclogs.Columns.Add($colDes)

    $commonseclogs.LoadDataRow( @("4720","User account created"), $true)
    $commonseclogs.LoadDataRow( @("4722","User account enabled"), $true)
    $commonseclogs.LoadDataRow( @("4724","password reset"), $true)
    $commonseclogs.LoadDataRow( @("4732","Account added or removed from a group"), $true)
    $commonseclogs.LoadDataRow( @("4738","User account change"), $true)
    $commonseclogs.LoadDataRow( @("1102","Audit log cleared"), $true)
    Write-Host $commonseclogs

    $commonsyslogs = New-Object System.Data.DataTable "Common System Logs"

    $commonsyslogs.Columns.Add((New-Object System.Data.DataColumn "EventID1"))
    $commonsyslogs.Columns.Add((New-Object System.Data.DataColumn "Description (system logs)"))
    
    $commonsyslogs.LoadDataRow(@("7030", "Basic service operations"), $true)
    $commonsyslogs.LoadDataRow(@("7045", "Service was installed"), $true)
    $commonsyslogs.LoadDataRow(@("1056", "DHCP server oddities"), $true)
    $commonsyslogs.LoadDataRow(@("10000", "COM Functionality (see Subtee's blogs)"), $true)
    $commonsyslogs.LoadDataRow(@("20001", "Device driver installation (many root-kits do this)"), $true)
    $commonsyslogs.LoadDataRow(@("20001", "Remote Access"), $true)
    $commonsyslogs.LoadDataRow(@("20003", "Service installation"), $true)

    #Write-Host $commonsyslogs

    $commonsyslogs | Format-Table "EventID1", "Description (system logs)"

    #Wridsate-Host " Security`n============
    #7045 = New service Installed
    #" -ForegroundColor Red





}

#is used to either supply a default 
function Get-commonlogs{

    
    Write-Host " AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" -ForegroundColor Red


}

#function that queries for a log, can be given a log type and EventID
#If none is given, then the user will be prompted for a log type and EventID
function Query-log{
    param(
    [Parameter()]
    [string]$Type=""
    #[Int32]$EventID=0
    #[String]$computer
    
    )

    if($Type -ne "Security" -or $Type -ne "System" -or $Type -ne "sec" -or $Type -ne "sys"){
        $Type = "Security"
        $Type = Read-Host -Prompt "System or Security logs?[security]"
    }

    if($Type -eq "sys"){$Type="system"}
    if($Type -eq "sec"){$Type="security"}

    
    $EventID = ""
    while($EventID -ne ""){
    
        $EventID = Read-Host -Prompt "Enter an EventID `n------------------`n>"
    
    }


    Get-WinEvent -LogName "system" 
    Get-WinEvent -FilterHashTable @{LogName = 'System';ID ='7045'}


}

function autorun{

    Write-Host "Scanning for suspicious event IDs..."


}

#-FilterHashTable @{LogName = ', type_of_log,';ID =', event_ID, '}


#wevtutil qe security /q:

#function to ask user what they want to do
while($true){


    $command = Read-Host -Prompt ">"

    if($command -eq "exit" -or $command -eq "q" -or $command -eq "logout")
    {
        break
    }

    &$command

}


##ask
##ask if shawn knows how to do a param where you just put a -l or -a and nothing else, like most linux commands work
#ask shawn if he knows why the 2 different methods of adding a column prints out 2 different tables



#wevtutil qe security /q: