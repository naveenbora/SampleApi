pipeline {
    agent any
    parameters{
        string(name:"IMAGENAME")
        
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build ')   
            }
        }
        stage('Test'){
          steps  {
                powershell(script:'dotnet test')
          }
       }
       stage('Publish'){
          steps  {
                powershell(script:'dotnet publish')
          }
          
       }
        stage('Archive'){
            steps  {
                powershell(script:'compress-archive SampleApi publish.zip -Update')
                archiveArtifacts artifacts: 'publish.zip'
            }
            
        }
        stage('Docker'){
            steps{
                
                powershell(script:'docker build -t HelloHiImage .')
                
            }
        }
        
        
    }

}
