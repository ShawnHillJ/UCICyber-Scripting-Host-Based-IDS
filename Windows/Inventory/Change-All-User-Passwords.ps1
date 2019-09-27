Get-ADUser  –Filter * -SearchBase “OU=Users, DC=domainName, DC=domainNameSuffix” | Set-ADAccountPassword  –Reset  –NewPassword (ConvertTo-SecureString  -AsPlainText -Force)
Write-Host -NoNewLine 'Press any key to continue...';
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');