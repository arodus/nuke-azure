pipeline {
    agent { label 'linux' }
    options {
        buildDiscarder(logRotator(numToKeepStr:'10'))
        timeout(time: 15, unit: 'MINUTES')
    }
    stages {
        stage('Compile') {
            steps {
                sh '/bin/bash ./build.sh Compile'
            }
        }
        stage('Test') {
            steps {
                sh '/bin/bash ./build.sh Test -Skip -NoInit'
            }
            post {
                always {
                    step([$class: 'XUnitPublisher', testTimeMargin: '3000', thresholdMode: 1, thresholds: [[$class: 'FailedThreshold', failureThreshold: '0']], tools: [[$class: 'XUnitDotNetTestType', deleteOutputFiles: false, failIfNotNew: false, pattern: 'output/tests.xml', skipNoTestFiles: false, stopProcessingIfError: true]]])
                }
            }
        }
		stage('Clone') {
            steps {
                sh '/bin/bash ./build.sh Clone -Skip -NoInit'
            }
        }
        stage('GenerateSpecifications') {
            steps {
                sh '/bin/bash ./build.sh GenerateSpecifications -Skip -NoInit'
            }
        }
		stage('GenerateTools') {
            steps {
                sh '/bin/bash ./build.sh GenerateTools -Skip -NoInit'
            }
        }
        stage('CompilePlugin') {
            steps {
                sh '/bin/bash ./build.sh CompilePlugin -Skip -NoInit'
            }
        }
        stage('Pack') {
            steps {
                sh '/bin/bash ./build.sh Pack -Skip -NoInit'
            }
			post {
				success {
					archiveArtifacts 'output/*'
				}
			}
        }
        
    }
}
