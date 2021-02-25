pipeline {
   agent any
   stages {
       when {
           branch "main"           
       }
       stage("build") {
           steps {
               dotnetBuild sdk: 'net5'
           }
       }
   }
}
