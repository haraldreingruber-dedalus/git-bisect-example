$content = Get-Content ../BisectApp/ViewModel/MainViewModel.cs

if ($content -like "*Hello svn enthousiast!*") {
    Write-Host "Found crappy content"
    exit 1
}
else {
    Write-Host "Probably great content"
    exit 0
}