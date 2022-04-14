<?php
    $user1 = $_GET['userid1'];
    $user2 = $_GET['userid2'];
    $content = $_GET['content'];
    $dbadress = "localhost";
    $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_oldchat');
    $result = $conn->query('SET names "utf8mb4"');
    if($conn->connect_error){
        echo "error";
    }
    else
    {
        $sqlZapros = "INSERT INTO `messages` (`id`, `from_whom`, `for_whom`, `content`, `datetime`) VALUES (NULL, '".$user1."', '".$user2."', '".$content."', now())";
        $result = $conn->query($sqlZapros);
        echo "Sended";
        $conn->close();
    }
?>