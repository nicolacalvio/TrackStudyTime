<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$nomeAmico = $_GET['nomeAmico'];
$result=$mysqli -> prepare("INSERT INTO amici (id_utente, id_amico) VALUES (?, ?) ");
$result->bind_param("ss", $nomeUtente, $nomeAmico);
$result->execute();
echo "aggiunto";