pipeline {
    agent any
    parameters{
        string(name:"SOLUTIONNAME")
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
                    bat 'docker build -t sampleapiimage .'
                    bat 'docker run -p 5005:80 sampleapiimage .'
                }
                
                
       }
}
