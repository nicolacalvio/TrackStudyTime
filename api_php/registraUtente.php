<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$password = $_GET['password'];
$mail = $_GET['mail'];
$result = $mysqli -> prepare("INSERT INTO utenti (nome_utente, password, mail) VALUES (?, ?, ?)");
$result->bind_param("sss", $nomeUtente, $password, $mail);
$result->execute();
echo "registrato";