<?php

//setlocale(LC_ALL, 'Russian_Russia.65001');

//echo "love reg ru";
    $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_cryptorin');
    
    $result = $conn->query('SET names "utf8"');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "SELECT COUNT(*) FROM messages WHERE from_whom = '31' and for_whom = '32' OR from_whom = '32' and for_whom = '31'";
        $result = $conn->query($sqlZapros);
        
        //var_dump($result);
        //echo $result[0];
        
        $row = $result->fetch_assoc();
        echo $row["COUNT(*)"];
        //var_dump($row);
        
        $conn->close();
    }
?>