<!DOCTYPE html>
<html lang="pl">

<head>
    <meta charset="UTF-8">
    <title>Kontynenty i miasta</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <div>
        <form method="POST" action="">
            <button type="submit" name="kontynent" value="Afryka">Afryka</button>
        </form>
        <form method="POST" action="">
            <button type="submit" name="kontynent" value="Ameryka Północna">Ameryka Północna</button>
        </form>
        <form method="POST" action="">
            <button type="submit" name="kontynent" value="Ameryka Południowa">Ameryka Południowa</button>
        </form>
        <form method="POST" action="">
            <button type="submit" name="kontynent" value="Azja">Azja</button>
        </form>
        <form method="POST" action="">
            <button type="submit" name="kontynent" value="Europa">Europa</button>
        </form>
    </div>
    <div>
        <?php
        // Połączenie z bazą danych
        $servername = "localhost";
        $username = "root";
        $password = "";
        $dbname = "kontynent";
        $conn = mysqli_connect($servername, $username, $password, $dbname);

        // Sprawdzenie czy przycisk został kliknięty
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
            // Pobranie wartości kontynentu z przycisku
            $kontynent = $_POST["kontynent"];

            // Zapytanie SQL o dwa największe miasta dla wybranego kontynentu
            $sql = "SELECT * FROM miasta WHERE kontynent='$kontynent' ORDER BY populacja DESC LIMIT 2";
            $result = mysqli_query($conn, $sql);

            // Wyświetlenie wyników
            if (mysqli_num_rows($result) > 0) {
                echo "<p>Twoje wyniki dla kontynentu $kontynent:</p>";
                while ($row = mysqli_fetch_assoc($result)) {
                    echo "<p>Nazwa miasta: " . $row["nazwa"] . " - Populacja: " . $row["populacja"] . "</p>";
                }
            } else {
                echo "<p>Brak wyników dla kontynentu $kontynent</p>";
            }
        }
        ?>
    </div>
</body>

</html>