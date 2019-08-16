pipeline {
    agent any
    parameters{
        string(name:"IMAGENAME")
        string(name:"DLL")
    }
    stages {
        stage('Build') {
            steps {
                bat 'dotnet build '   
            }
        }
        stage('Test'){
          steps  {
                bat 'dotnet test'
          }
       }
       stage('Publish'){
          steps  {
                bat 'dotnet publish'
          }
          
       }
      
    }
     post{
                success{
                    archiveArtifacts '**'
                    bat 'docker build --build-arg DLL_NAME= %DLL% .'
                    bat 'docker run -p 5007:80 %IMAGENAME% .'
                }
                
                
       }
}
