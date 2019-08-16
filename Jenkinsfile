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
                    bat 'docker build -t %IMAGENAME% .'
                    bat 'docker run -p 5007:80 %IMAGENAME% .'
                }
                
                
       }
}
