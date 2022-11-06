$folderChaves = 'd:\ChavesData'
$OutFile = "d:\ChavesData\norton.csv"

if(-not(Test-Path -Path $folderChaves))
{
    mkdir $folderChaves
}

 ForEach-Object {
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    },
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    },
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    },
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    },
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    },
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    },
    [PsCustomObject]@{
        Username = "cursos.alura.com.br"
        Password = "https://cursos.alura.com.br/"
        Title = "bernardo_otavio_sales@ft.unicamp.br"
        "Login URL" = "pDh@X3I74$Nz"
        Notes = "pDh@X3I74$Nz"
    }

} | Export-Csv -Path $Outfile -UseQuotes AsNeeded -NoTypeInformation;

Clear-Host

Write-Host "MOCK CREATED `u{2705}"

if ((Test-Path -Path $OutFile -PathType Leaf)) 
{
    $PASS = Import-Csv -Path $file
    $PASS | Format-Table
    Write-Host "ROWS:" $PASS.Length
    Write-Host $OutFile
    
 }
 else 
 {
    Write-Host "NO FILE"
 }
