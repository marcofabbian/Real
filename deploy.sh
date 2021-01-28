#WORKSPACE=/var/lib/jenkins/workspace/RealEstate_Search_Engine
args=$1

if [ -z $args ]; then
        sudo echo "Error : empty args."
        exit 1
fi

if [ "$args" = "stopservices" ]; then
        systemctl stop realservicefile.service
elif [ "$args" = "deployartefacts" ]; then
        source_directory=$WORKSPACE/artifacts
        target_directory=/var/www/real.com/dot_net_api

        array=$(ls -d $source_directory/*)

        for i in $array
        do
                sudo cp -R $i $target_directory/
        done

elif [ "$args" = "startservices" ]; then
        sudo systemctl restart realservicefile.service
fi