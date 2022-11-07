$file = 'd:\chaves\pass.csv'


if ((Test-Path -Path $file -PathType Leaf)) {

$header = Ged-Content -LiteralPath $file |
          Where-Object { $_ -notmatch '^#type' } |
          Select-Object -First 1

Set-Content -LiteralPath $file -Value $header
Write-Output "DELETED ROWS"
}
else
{
  Write-Output "FILE DOES NOT EXIST"
}