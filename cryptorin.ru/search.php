<?php
    $nickname = $_GET['nickname'];
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
            $row = $result->fetch_assoc();
            echo "ok ".$row["id"];
        }
        else {
            echo "null";
        }
        $conn->close();
    }
?>