<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nome = $_GET['nome'];
$data = date("Y/m/d");
$sql = $mysqli->prepare("select tempo_studio from tempi where utente=? and dataInserimento=?");
$sql ->bind_param("ss", $nome, $data);
$sql->execute();
$result = $sql->get_result();
if ($myrow = $result->fetch_array(MYSQLI_NUM)) {
    echo gmdate("H:i:s",$myrow[0]);
}
$mysqli->close();
//devo prendere il tempo di questo giorno e resitutirlo in ordine di secondi, minuti ore