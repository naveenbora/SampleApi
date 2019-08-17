pipeline {
    agent any
    parameters{
        
        string(name:"USERNAME",defaultValue:"naveenbora143")
        
        string(name:"DOCKERREPONAME",defaultValue:"sampleapi")
        string(name:"TAGNAME",defaultValue:"api")
        string(name:"PORT",defaultValue:"9000:80")
    }
    stages{
        stage('PULLDOCKER'){
            steps{
                
                powershell(script:'docker run -p ${env:PORT} naveenbora143/sampleapi:api')
            }
        }
        
        
    }

}
