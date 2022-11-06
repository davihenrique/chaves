$file = 'c:\chaves\pass.csv'

if ((Test-Path -Path $file -PathType Leaf)) {
    $PASS = Import-Csv -Path $file
    $PASS | Format-Table
    Write-Host "ROWS:" $PASS.Length
    
 }
 else {
    Write-Host "NO FILE"
 }