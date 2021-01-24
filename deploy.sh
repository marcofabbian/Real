#WORKSPACE=/var/lib/jenkins/workspace/RealEstate_Search_Engine
source_directory=$WORKSPACE/artifacts
target_directory=/var/www/real.com/dot_net_api

array=$(ls -d $source_directory/*)

for i in $array
do
        sudo cp -R $i $target_directory/
done