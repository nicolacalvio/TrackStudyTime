<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$dataPartenza = $_GET['partenza'];
$dataFinale = $_GET['finale'];
$sql = $mysqli->prepare("select sum(tempo_studio), avg(tempo_studio), (sum(tempo_studio)/DATEDIFF(CURDATE(),?)) from tempi where utente=? and dataInserimento between ? and ? ");
$sql ->bind_param("ssss", $dataPartenza,$nomeUtente, $dataPartenza, $dataFinale);
$sql->execute();
$result = $sql->get_result();
if ($result) {
    $row = $result->fetch_array(MYSQLI_NUM);
    echo $row[0].";".gmdate("H:i:s",$row[1]).";".gmdate("H:i:s",$row[2]);
}
$mysqli->close();
