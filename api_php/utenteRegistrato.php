<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$sql = "SELECT nome_utente FROM utenti where nome_utente=?";
$result = $mysqli -> prepare($sql);
$result->bind_param("s", $nomeUtente);
$result->execute();
$result1 = $result->get_result();
if($result1){
    if($result1->num_rows >0){
        echo "registrato";
    }else{
        echo "no";
    }
}else{
    echo "no";
}
// Free result set
$result1 -> free_result();

$mysqli -> close();