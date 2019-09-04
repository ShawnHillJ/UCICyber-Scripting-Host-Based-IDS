param(
    [Parameter(Mandatory=$true)][string]$file
    )
$permitted = (Get-Content -Path $file).Trim().Split('`n')
$dest_addr_index = 2
$temppath = 'C:\Users\Admin\Desktop\log.txt'
$blocked =  'C:\Users\Admin\Desktop\blocked.txt'
while ($true){
    $raw_content = ((Get-NetTCPConnection -AppliedSetting Internet | Out-String) -replace '\s+',',').split(',')
    $header = $raw_content[1..7]
    $data = $raw_content[14..($raw_content.Length-1)]
    if(!(Test-Path $temppath)){
        $header_line = $header -join ','
        ($header_line + ',' + 'Date')| Set-Content -Path $temppath   
    }
    For($i=0; $i -lt $data.Length; $i+=7){
        $line = $data[($i+1)..($i+7)] -join ','
        if ($line.Length -gt 0){
            if ($permitted.Contains($data[$(i+1+($dest_addr_index))])){
                Add-Content -Path $blocked $line
                Stop-Process ($data[$(i+7)])
            }

            $line += ','+$(Get-Date) 
            Add-Content -Path $temppath $line
        }
    Start-Sleep -Seconds 30
    }
}