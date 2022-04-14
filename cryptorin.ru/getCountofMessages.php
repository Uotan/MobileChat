<?php
    $user1 = $_GET['userid1'];
    $user2 = $_GET['userid2'];
    $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_oldchat');
    $result = $conn->query('SET names "utf8"');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "SELECT COUNT(*) FROM messages WHERE from_whom = '".$user1."' and for_whom = '".$user2."' OR from_whom = '".$user2."' and for_whom = '".$user1."'";
        $result = $conn->query($sqlZapros);
        
        //var_dump($result);
        //echo $result[0];
        
        $row = $result->fetch_assoc();
        echo $row["COUNT(*)"];
        //var_dump($row);
        
        $conn->close();
    }
?>