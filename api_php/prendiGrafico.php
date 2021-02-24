<?php
$configdb = require 'credentials.php';
$mysqli = new mysqli($configdb["db_host"],$configdb["db_user"],$configdb["db_pass"],$configdb["db_name"]);
$nomeUtente = $_GET['nome'];
$dataPartenza = $_GET['partenza'];
$dataFinale = $_GET['finale'];
$sql = $mysqli->prepare("select tempo_studio, dataInserimento from tempi where utente=? and dataInserimento between ? and ? order by dataInserimento ASC");
$sql ->bind_param("sss", $nomeUtente, $dataPartenza, $dataFinale);
$sql->execute();
$result = $sql->get_result();
if ($result) {
    while($row = $result->fetch_array(MYSQLI_NUM)) {
        echo $row[1].";".$row[0]."*";
    }
}
$mysqli->close();