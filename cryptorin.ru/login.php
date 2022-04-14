<?php 

    $nickname = addslashes($_GET['login']);
    $password = addslashes($_GET['password']);
    
    $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_oldchat');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "SELECT * FROM `users` WHERE nickname = '".$nickname."' and PASSWORD = '".$password."'";
        $result = $conn->query($sqlZapros);
        
        $sqlZapros2 = "SELECT id FROM `users` WHERE nickname = '".$nickname."'";
        $result2 = $conn->query($sqlZapros2);

        if ($result->num_rows > 0) {
            $row = $result2->fetch_assoc();
            echo "ok ".$row["id"];
        }
        else {
            echo "Error";
        }
        $conn->close();
    }
?>

