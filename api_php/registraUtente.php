<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$password = $_GET['password'];
$mysqli -> prepare("INSERT INTO utenti (nome_utente, password) VALUES (?, ?)");
$mysqli->bind_param("ss", $nomeUtente, $password);
$mysqli->execute();
echo "registrato";