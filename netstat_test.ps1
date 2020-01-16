
$log_path = 'C:\Users\Admin\Desktop\log.txt'
$session_path = 'C:\Users\Admin\Desktop\session.txt'
$temp_raw = ((Get-NetTCPConnection -AppliedSetting Internet | Out-String) -replace '\s+',',').split(',')
$temp_raw = $temp_raw[15..($temp_raw.Length)]
$temp_log = @()

Function Write-Log{
    Param($array, $file_path, $line_addon)
    foreach($line in $array){
        if($line.Length -gt 0){
            Add-Content -Path ($file_path) ($line + $line_addon)
        }
    }
}


For($i=14; $i -lt $temp_raw.Length;$i+=7){
    $temp_log += (($temp_raw[($i)..($i+6)]) -join ',')
}

while ($true){
    $raw_content = ((Get-NetTCPConnection -AppliedSetting Internet | Out-String) -replace '\s+',',').split(',')
    $data_array=@()
    $header = ($raw_content[1..7] -join ',')
    Clear-Content -Path $session_path

    For($i=14;$i -lt $raw_content.Length;$i+=7){
        $data_array += ($raw_content[($i+1)..($i+6)] -join ',')
    }

    if(!(Test-Path $log_path)){
        Set-Content -Path $log_path ($header + ',Date,Status')
        Write-Log($temp_log, $log_path, (',' + $(Get-Date) + ',new'))   
    }

    For($i=0; $i -lt $data_array.Length; $i++){
        $line = $data_array[$i]
        if ($line.Length -gt 0){
            if(!($temp_log.Contains($line))){
                $line += ','+$(Get-Date)+',new'
                $line 
                Add-Content -Path $log_path -Value $line 
                Add-Content -Path $session_path -Value $line 
            }
            
        }
    }
     
    For($i=0; $i -lt $temp_log.Length;$i++){
        $line = $temp_log[$i]
        if ($line.Length -gt 0){
            if(!($data_array.Contains($line))){
                $line += ','+$(Get-Date)+',closed'
                $line 
                Add-Content -Path $log_path -Value $line 
                Add-Content -Path $session_path -Value $line 
            }
        }
    }

    $temp_log = $null
    $temp_log = $data_array
    Start-Sleep -Seconds 15
}
    