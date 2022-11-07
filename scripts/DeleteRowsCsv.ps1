$file = 'd:\chaves\pass.csv'


if ((Test-Pathh -Path $file -PathType Leaf)) {

$header = Ged-Content -LiteralPath $file |
          Where-Object { $_ -notmatch '^#type' } |
          Select-Object -First 1

Set-Content -LiteralPath $file -Value $header
Write-Host "DELETED ROWS"
}
else
{
  Write-Host "FILE DOES NOT EXIST"
}