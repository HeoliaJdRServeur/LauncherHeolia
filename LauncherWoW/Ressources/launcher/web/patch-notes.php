<?php
    require_once 'config.php';
?>
<html lang="fr-FR">
    <head>
        <meta http-equiv="content-type" content="text/html; charset=UTF-8">
        <title><?php echo $title; ?></title>
        <style type="text/css">
        <!--
            <?php require_once './style/css/common.php'; ?>
        -->
        </style>
    </head>

    <body onbeforecopy="return false" oncontextmenu="return false" oncopy="return false" ondragstart="return false" onselect="return false" onselectstart="return false" style="background-image:url('<?php echo $style['back_pn']; ?>')">
        <a class="logo" href="<?php echo $link['logo']; ?>" target="_blank"></a>

        <div class="copyright">
            <a href="<?php echo $link['copyright']; ?>" target="_blank"></a>

            <div>
                <?php
                    for($i = 0; $i < 4; $i++) { echo '<div class="shadow' . $i . '">' . $copyright . '</div>'; }
                    echo $copyright;
                ?>
            </div>
        </div>

        <div class="top_panel">
            <div class="top_panel_int">
                <a href="<?php echo $link['store']; ?>" style="background-image:url('<?php echo $style['banner_store']; ?>')" target="_blank"></a>
            </div>
        </div>

        <a class="patch_back" href="./index.php" target="_self"></a>

        <div class="patchnotes">
            <font face="arial" size="3"><p>
                <b>Mise à jour du client de World of Warcraft 1.0</b>
            </p></font>

            <font face="arial" size="2"><p>
                Les dernières notes de mise à jour peuvent toujours être consultées sur la page
                <a href="http://www.tonsite.fr/actualite.php" target="_blank">
                Informations complementaires sur les mises a jours.</a>
            </p></font>

            <font face="arial" size="2">

<!-- Exemple -->
                <p>
                    <b>L'Appel de la Croisade</b>
                    <ul>
                        <li>Depuis l'ouverture du tournoi d'Argent au nord-est de la Couronne de glace, les aventuriers sont venus de tout Azeroth et au-delà
                        pour prouver leur valeur en plein cœur du domaine du roi-liche. Sous un ciel orageux, les participants du tournoi affinent leurs
                        compétences au combat et s'affrontent dans des joutes violentes pour obtenir le titre de champion. Mais ces héros doivent encore
                        affronter le plus grand des défis&nbsp;: le colisée d'Argent. De redoutables champions de la Horde et de l'Alliance, des bêtes féroces
                        et des lieutenants du Fléau sont parmi les opposants qui attendent les aventuriers dans cette arène de gladiateurs. Peu survivront aux
                        dangers du colisée, mais la Croisade d'argent est certaine que les valeureux héros qui sortiront vainqueurs de cette épreuve seront prêts
                        à rejoindre l'offensive contre la citadelle de la Couronne de glace pour mettre fin au règne de terreur du roi-liche.</li>
                    </ul>
                </p>

                <p>
                    <b>L'île des Conquérants</b>
                    <ul>
                        <li>Au large des côtes du Norfendre, les troupes de la Horde et de l'Alliance sont engagées dans un combat épique pour la
                        domination d'une île minuscule riche en ressources. La proximité de ce champ de bataille rocailleux, connu sous le nom d'île
                        des Conquérants, avec la Couronne de glace en a fait une position recherchée dans la guerre contre le roi-liche. Chaque faction a déployé
                        des armes dévastatrices pour chasser l'autre de cette position stratégique. Jour et nuit, le sol frémit sous les lourds véhicules de
                        siège tandis que de monstrueux vaisseaux bombardent les positions ennemies avec leurs canons mortels. Le conflit sanglant se propage
                        sur toute l'île tandis que de nouveaux héros viennent en aide à leur faction. Nul ne sait quelle bannière flottera triomphalement
                        au-dessus de l'île des Conquérants et ce que cette victoire co&ucirc;tera à tous.</li>
                    </ul>
                </p>

                <p>
                    <b>Général</b>
                    <ul>
                        <li>La construction du Colisée des croisés est achevée&nbsp;! Il est possible de choisir le mode normal et héro&iuml;que pour les
                        nouveaux raids du Colisée des croisés en utilisant les réglages de difficulté du donjon. Ceci s'applique aux versions 10 et 25 joueurs.
                        Les raids 10 joueurs (normal), 25 joueurs (normal), 10 joueurs (héro&iuml;que) et 25 joueurs (héro&iuml;que) ont tous des chronomètres
                        de réinitialisation séparés.</li>

                        <ul>
                            <li>L'épreuve du champion</li>
                            <ul>
                                <li>Donjon à 5 joueurs (mode normal et héro&iuml;que).</li>
                                <li>Une nouvelle quête journalière est disponible auprès du donneur de quêtes journalières en donjon héro&iuml;que.</li>
                            </ul>

                            <li>L'épreuve du croisé</li>
                            <ul>
                                <li>Donjon de raid à 10 et 25 joueurs (mode normal).</li>
                            </ul>

                            <li>L'épreuve du grand croisé</li>
                            <ul>
                                <li>Donjon de raid à 10 et 25 joueurs (mode héro&iuml;que).</li>
                                <li>Offrande des croisés&nbsp;: actif en mode héro&iuml;que uniquement, le système d'offrande limitera les joueurs en nombre de tentatives
                                allouées chaque semaine au raid. Des récompenses supplémentaires pourront être gagnées selon le nombre de tentatives restant pour
                                l'offrande chaque semaine, quand le boss final est vaincu.</li>
                            </ul>
                        </ul>

                        <li>Rendez-vous sur le nouveau champ de bataille de type siège, l'île des Conquérants, pour vous battre à 40 contre 40 pour le
                        contrôle d'un emplacement stratégique, qui regorgent de ressources prisées par la Horde et l'Alliance.</li>

                        <ul>
                            <li>Deux tranches de niveaux sont disponibles&nbsp;: 71-79 et 80.</li>
                            <li>Défendez l'enceinte de votre donjon et protégez votre général en tuant les joueurs ennemis et en détruisant leurs véhicules de
                            siège.</li>
                            <li>Capturez les docks, le hangar à canonnière et l'atelier de siège pour avoir accès à des véhicules de siège destructeurs, ou à
                            des attaques stratégiques sur la base de votre ennemi.</li>
                            <li>Capturez la raffinerie ou la carrière pour leurs ressources, afin d'engranger des renforts, un flot continu de bonus d'honneur
                            et une augmentation de 15% des dég&acirc;ts des véhicules de siège par point contrôlé par votre équipe.</li>
                            <li>Pour obtenir la victoire, percez les défenses du donjon ennemi (ou trouvez un autre moyen pour pénétrer à l'intérieur) et tuez
                            le général adverse, ou exterminez vos adversaires jusqu'à ce qu'ils n'aient plus de renforts.</li>
                        </ul>

                        <li>Le tournoi d'Argent s'agrandit :</li>
                        <ul>
                            <li>De toutes nouvelles quêtes journalières et récompenses de la Croisade d'argent ont été ajoutées pour les joueurs au titre de
                            Croisé. Les récompenses comprennent une nouvelle bannière de la Croisade d'argent ainsi qu'un nouveau tabard (qui peut téléporter
                            les joueurs dans l'enceinte du tournoi), un écuyer sur une monture (qui peut périodiquement porter des messages de banque, de courrier
                            ou de marchands pour le joueur), la monture destrier de la Croisade d'argent réservée aux paladins, et de nouveaux objets de qualité
                            Héritage.</li>
                            <li>De toutes nouvelles quêtes journalières et récompenses du Concordat argenté et des Saccage-soleil ont été ajoutées pour les
                            joueurs exaltés auprès de ces factions. Les récompenses comprennent des tabards, de nouvelles montures terrestres et volantes ainsi
                            qu'un nouveau familier.</li>
                            <li>Alors que vous pensiez en avoir terminé avec le Chevalier noir, il fait un étonnant retour dans le tournoi. Attendez un peu,
                            vous ne l'aviez pas déjà tué&nbsp;?</li>
                        </ul>

                        <li>Nouvelle fonction pour le butin en donjon</li>
                        <ul>
                            <li>Les joueurs peuvent maintenant échanger des objets liés avec les autres membres du raid ou du groupe éligibles pour le butin.
                            Ce système fonctionne comme le système Racheter cet objet et laisse 2 heures aux joueurs pour échanger un objet une fois qu'il a été
                            ramassé. Les joueurs qui choisissent d'enchanter ou de sertir des gemmes sur l'objet reçoivent une dernière demande de
                            confirmation avant de perdre la possibilité d'échanger l'objet.</li>
                        </ul>

                        <li>De nouvelles apparences pour les formes de félin et d'ours des druides ont été ajoutées. Il y a à présent cinq combinaisons uniques de couleurs pour chaque forme et faction. La modification de la couleur des cheveux (elfes de la nuit) ou de la couleur de peau (taurens) dans un salon de coiffure modifiera l'apparence des formes de félin et d'ours.</li>
                    </ul>
                </p>


                <p>
                    <b>JcJ</b>
                    <ul>
                        <li>Arènes</li>
                        <ul>
                            <li>&Agrave; compter de la saison&nbsp;7, les joueurs ne pourront plus acheter les armes et armures d'épaules les plus récentes et ne pourront se qualifier pour le titre et les récompenses de gladiateur en ne participant qu'aux matchs en 2c2. Des cotes obtenues en 3c3 et 5c5 sont désormais requises pour ces récompenses. Les autres objets de la nouvelle saison sont toutefois disponibles pour les combattants toutes catégories (les restrictions classiques de cotes s'appliquent toujours).</li>
                            <li>&Eacute;gouts de Dalaran</li>
                            <ul>
                                <li>La taille générale de l'arène a été augmentée de 25%.</li>
                                <li>Les montures peuvent maintenant être utilisées dans cette arène.</li>
                                <li>La position et les collisions des caisses de la plateforme centrale ont été modifiées.</li>
                            </ul>

                            <li>Arène des valeureux</li>
                            <ul>
                                <li>Le mur de flammes a été supprimé.</li>
                            </ul>

                            <li>Ruines de Lordaeron</li>
                            <ul>
                                <li>Des alcôves ont été supprimées des pièces de départ.</li>
                                <li>Les collisions autour de la tombe centrale ont été lissées pour empêcher que les joueurs ne soient coincés sur le terrain aussi souvent.</li>
                            </ul>
                        </ul>
                    </ul>
                </p>
            </font>
        </div>
    </body>
</html>
