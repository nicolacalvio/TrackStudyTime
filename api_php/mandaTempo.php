<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$tempo = $_GET['tempo'];
$password=$_GET['password'];
$data = date("Y/m/d");
//controllare se le credenziali sono giuste
$result1 = $mysqli->prepare("select nome_utente from utenti where nome_utente=? and password=?");
$result1->bind_param("ss", $nomeUtente, $password);
$result1->execute();
if($result1->num_rows>0){
    $result = $mysqli -> prepare("select utente from tempi where dataInserimento=? and utente=?");
    $result->bind_param("ss", $data, $nomeUtente);
    $result->execute();
    if($result->num_rows >0){
        $mysqli -> prepare("UPDATE tempi set tempo_studio=? where dataInserimento=? and utente=?");
        $mysqli->bind_param("ss", $tempo, $data, $nomeUtente);
        $mysqli->execute();
        echo "mandato";
    }else{
        $mysqli -> prepare("INSERT INTO tempi (tempo_studio, utente, dataInserimento) VALUES (?, ?, ?)");
        $mysqli->bind_param("sss", $tempo, $nomeUtente, $data);
        $mysqli->execute();
        echo "mandato";
    }
}else{
    echo "no";
}


//se non ci sono record per quel giorno con quel utente faccio una insert altrimenti devo fare una update
