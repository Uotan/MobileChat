<?php 
    $nickname = $_GET['login'];
    $password = $_GET['password'];
   $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_oldchat');
    $result = $conn->query('SET names "utf8"');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "SELECT * FROM `users` WHERE nickname = '".$nickname."'";
        $result = $conn->query($sqlZapros);
        
        if ($result->num_rows > 0) {
            echo "UserExists";
        }
        else {
            $sqlZapros = "INSERT INTO `users` (`id`, `nickname`, `password`) VALUES (NULL, '".$nickname."', '".$password."');";
            $result = $conn->query($sqlZapros);
            echo "UserCreated";
        }
        $conn->close();
    }
?>

