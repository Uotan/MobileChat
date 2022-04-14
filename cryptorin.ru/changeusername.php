<?php 
    $nicknameOld = $_GET['nicknameOld'];
    $nicknameNew = $_GET['nicknameNew'];
    $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_oldchat');
    $result = $conn->query('SET names "utf8"');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "SELECT * FROM `users` WHERE nickname = '".$nicknameOld."'";
        $resultOLD = $conn->query($sqlZapros);
        $sqlZapros = "SELECT * FROM `users` WHERE nickname = '".$nicknameNew."'";
        $resultNEW = $conn->query($sqlZapros);
        
        if ($resultOLD->num_rows != 0 && $resultNEW->num_rows == 0) {
            $sqlZapros = "UPDATE `users` SET `nickname` = '".$nicknameNew."' WHERE `users`.`nickname` = '".$nicknameOld."';";
            $result = $conn->query($sqlZapros);
            echo "Updated";
        }
        else
        {
            echo "Error";
        }
        $conn->close();
    }
?>

