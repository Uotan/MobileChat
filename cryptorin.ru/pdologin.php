<?php 

    $nickname = addslashes($_GET['login']);
    $password = addslashes($_GET['password']);
    
    
    $host = '127.0.0.1';
    $db   = 'u1621366_oldchat';
    $user = 'u1621366_public';
    $pass = 'iD5mC6eT6v';
    $charset = 'utf8';

    $dsn = "mysql:host=$host;dbname=$db;charset=$charset";
    $opt = [
        PDO::ATTR_ERRMODE            => PDO::ERRMODE_EXCEPTION,
        PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
        PDO::ATTR_EMULATE_PREPARES   => false,
    ];
    
    $pdo = new PDO($dsn, $user, $pass, $opt);
    
    $stmt = $pdo->query("SELECT * FROM `users` WHERE nickname = 'ник на русском' and PASSWORD = 'пароль'");
    while ($row = $stmt->fetch())
    {
        echo $row['nickname'];
    }
    
    // $dbadress = "localhost";
    // $conn = new mysqli($dbadress, 'u1621366_public', 'iD5mC6eT6v','u1621366_cryptorin');
    // if($conn->connect_error){
    //     echo "error";
    // }
    // else
    // {
    //     $sqlZapros = "SELECT * FROM `users` WHERE nickname = '".$nickname."' and PASSWORD = '".$password."'";
    //     $result = $conn->query($sqlZapros);
        
    //     $sqlZapros2 = "SELECT id FROM `users` WHERE nickname = '".$nickname."'";
    //     $result2 = $conn->query($sqlZapros2);

    //     if ($result->num_rows > 0) {
    //         $row = $result2->fetch_assoc();
    //         echo "ok ".$row["id"];
    //     }
    //     else {
    //         echo "Error";
    //     }
    //     $conn->close();
    // }
    


?>

