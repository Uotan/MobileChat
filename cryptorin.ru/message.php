<?php
    $user1 = $_GET['userid1'];
    $user2 = $_GET['userid2'];
    $count = $_GET['count'];
    
    settype($count, 'integer');
    
    $host = '127.0.0.1';
    $db   = 'u1621366_cryptorin';
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
    
    
    $sqlCountQuery = "SELECT COUNT(*) FROM messages WHERE from_whom = '".$user1."' and for_whom = '".$user2."' OR from_whom = '".$user2."' and for_whom = '".$user1."'";
    $STH_count  = $pdo->query($sqlCountQuery);
    $resultCount = $STH_count->fetch();
    $countOfMessagesOnDB = $resultCount["COUNT(*)"];
    
    settype($countOfMessagesOnDB, 'integer');
    
    $deltaMessages = $countOfMessagesOnDB - $count;

    
    
    function insert($user = [])
    {
        
        $array_level['from_whom'] = $user[0];
        $array_level['datetime'] = $user[1];
        $array_level['content'] = $user[2];
        return $array_level;
    }
        $sqlquery = "SELECT `from_whom`,`content`,`datetime` FROM `messages` WHERE from_whom = '".$user1."' and for_whom = '".$user2."' OR from_whom = '".$user2."' and for_whom = '".$user1."' LIMIT ".$deltaMessages.", ".$count;

        $STH  = $pdo->query($sqlquery);
        $result = $STH->fetchAll();
        $array_level = array();
        foreach( $result as $row ) {
            $array_level[] = insert([$row["from_whom"],$row["datetime"],$row["content"]]);
        }
        $json = json_encode($array_level);
        echo $json;
    
?>