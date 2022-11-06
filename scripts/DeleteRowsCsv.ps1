$file = 'c:\chaves\pass.csv'

$header = Get-Content -LiteralPath $file |
          Where-Object { $_ -notmatch '^#type' } |
          Select-Object -First 1

Set-Content -LiteralPath $file -Value $header
Write-Host "DELETED ROWS"