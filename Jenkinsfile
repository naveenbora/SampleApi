pipeline {
    agent any
    parameters{
        
        string(name:"USERNAME",defaultValue:"naveenbora143")
        
        string(name:"DOCKERREPONAME",defaultValue:"sampleapi")
        string(name:"TAGNAME",defaultValue:"api")
        
    }
    stages{
        stage('PULLDOCKER'){
            steps{
                
                powershell(script:'docker run -p 9000:80 naveenbora143/sampleapi:api')
            }
        }
        
        
    }

}
