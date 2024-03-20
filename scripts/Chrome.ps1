$folderChaves = 'd:\ChavesData'
$OutFile = "d:\ChavesData\chrome.csv"

if(-not(Test-Path -Path $folderChaves))
{
    mkdir $folderChaves
}

 ForEach-Object {
        [PsCustomObject]@{
        name = "cursos.exemplo.com.br"
        url = "https://cursos.exemplo.com.br/"
        username = "bernardo_otavio_sales@ft.unicamp.br"
        password = "pDh@X3I74$Nz"
    },
        [PsCustomObject]@{
        name = "cursos.exemplo.com.br"
        url = "https://cursos.exemplo.com.br/"
        username = "bernardo_otavio_sales@ft.unicamp.br"
        password = "ef13E54ZSu$x"
    },
       [PsCustomObject]@{
        name = "www.loja.com.br"
        url = "https://www.loja.com.br/"
        username = "lais_sophie_viana@dinamicaconsultoria.com"
        password = "S8G%d!35kfjd"
    },
        [PsCustomObject]@{
        name = "www.musica.com"
        url = "https://www.musica.com/password/reset"
        username = "lais_sophie_viana@dinamicaconsultoria.com"
        password = "vm819y#&CLVAoN2s845h"
    },
        [PsCustomObject]@{
        name = "firefox.com"
        url = "https://firefox.com/"
        username = "lais_sophie_viana@dinamicaconsultoria.com"
        password = "tD0qX%0DHQ9w2PMj2hMv"
    },
        [PsCustomObject]@{
        name = "www.musica.com"
        url = "https://www.musica.com/password/reset"
        username = "lais_sophie_viana@dinamicaconsultoria.com"
        password = "vm819y#&CLVAoN2s845h"
    }

} | Export-Csv -Path $Outfile -UseQuotes AsNeeded -NoTypeInformation;

Write-Host "MOCK CREATED `u{2705}"

if ((Test-Path -Path $OutFile -PathType Leaf)) 
{
    $PASS = Import-Csv -Path $OutFile
    $PASS | Format-Table
    Write-Host "ROWS:" $PASS.Length
    Write-Host $OutFile
    
 }
 else 
 {
    Write-Host "NO FILE"
 }