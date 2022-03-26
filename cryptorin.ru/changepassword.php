<?php
    $userid = $_GET['userid'];
    $passwordOld = $_GET['passwordOld'];
    $passwordNew = $_GET['passwordNew'];
   $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_cryptorin');
    $result = $conn->query('SET names "utf8"');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "SELECT * FROM `users` WHERE id = '".$userid."' AND password = '".$passwordOld."'";
        $resultOLD = $conn->query($sqlZapros);

        if ($resultOLD->num_rows != 0) {
            $sqlZapros = "UPDATE `users` SET `password` = '".$passwordNew."' WHERE `users`.`id` = ".$userid.";";
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

