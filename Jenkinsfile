pipeline {
    agent any
    parameters{
        string(name:"IMAGENAME",defaultValue:"sampleapiimage")
        string(name:"SOLUTIONNAME",defaultValue:"SampleApi.sln")
        string(name:"USERNAME",defaultValue:"naveenbora143")
        string(name:"PASSWORD",defaultValue:"8463971887")
        string(name:"DOCKERREPONAME",defaultValue:"sampleapi")
        string(name:"TAGNAME",defaultValue:"api")
        
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build ${env:SOLUTIONNAME} -p:Configuration=release -v:q')   
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
                
                archiveArtifacts artifacts: 'SampleApi/bin/Debug/netcoreapp2.2/publish/*.*',fingerprint:true
            }
            
        }
        stage('Docker'){
            steps{
                
                powershell(script:'docker build -t ${env:IMAGENAME} .')
                powershell(script:'docker login -u ${env:USERNAME} -p ${env:PASSWORD}')
                powershell(script:'docker tag ${env:IMAGENAME}:latest ${env:USERNAME}/${env:DOCKERREPONAME}:${env:TAGNAME}')
                powershell(script:'docker push ${env:USERNAME}/${env:DOCKERREPONAME}:${env:TAGNAME}')
            }
        }
        
        
    }

}

