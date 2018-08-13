pipeline {
    agent { label 'linux' }
    options {
        buildDiscarder(logRotator(numToKeepStr:'10'))
        timeout(time: 15, unit: 'MINUTES')
		skipDefaultCheckout()
    }
    stages {
		stage('Checkout') {
            steps {
				sh 'git config --global user.email "34026207+nuke-bot@users.noreply.github.com" && git config --global user.name "nuke-bot"'
				checkout scm
            }
        }
        stage('Compile') {
            steps {
                sh '/bin/bash ./build.sh Compile'
            }
        }
        stage('Test') {
            steps {
                sh '/bin/bash ./build.sh Test -Skip'
            }
            post {
                always {
                    step([$class: 'XUnitPublisher', testTimeMargin: '3000', thresholdMode: 1, thresholds: [[$class: 'FailedThreshold', failureThreshold: '0']], tools: [[$class: 'XUnitDotNetTestType', deleteOutputFiles: false, failIfNotNew: false, pattern: 'output/tests.xml', skipNoTestFiles: false, stopProcessingIfError: true]]])
                }
            }
        }
		stage('Clone') {
            steps {
                sh '/bin/bash ./build.sh Clone -Skip'
            }
        }
        stage('GenerateSpecifications') {
            steps {
                sh '/bin/bash ./build.sh GenerateSpecifications -Skip'
            }
        }
		stage('GenerateTools') {
            steps {
                sh '/bin/bash ./build.sh GenerateTools -Skip'
            }
        }
        stage('CompilePlugin') {
            steps {
                sh '/bin/bash ./build.sh CompilePlugin -Skip'
            }
        }
        stage('Pack') {
            steps {
                sh '/bin/bash ./build.sh Pack -Skip'
            }
			post {
				success {
					archiveArtifacts 'output/*'
				}
			}
        }
        
    }
}
