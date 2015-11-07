<?php
    require_once 'config.php';
	error_reporting(0);
?>
<html lang="fr-FR">
    <head>
        <meta http-equiv="content-type" content="text/html; charset=UTF-8">
        <title><?php echo $title; ?></title>
        <style type="text/css">
        <!--
            <?php require_once './style/css/common.css'; ?>
        -->
        </style>
    </head>
    <body onbeforecopy="return false" oncontextmenu="return false" oncopy="return false" ondragstart="return false" onselect="return false" onselectstart="return false" style="background-image:url('<?php echo $style['back']; ?>')">
        <a class="logo" href="<?php echo $link['logo']; ?>" target="_blank"></a>
        <a class="launcher_link" href="<?php echo $link['launcher']; ?>" target="_blank"></a>
        <div class="top_panel">
            <div class="top_panel_int">
                <a href="<?php echo $link['store']; ?>" style="background-image:url('<?php echo $style['banner_store']; ?>')" target="_blank"></a>
            </div>
        </div>

        <div id="launcher_banner">
            <a href="<?php echo $link['flash_banner']; ?>" target="_blank"><img src="<?php echo $style['flash_fix']; ?>" target="_blank"></a>
        </div>
        <div class="news_box">
            <div class="news">
                <div class="title">
                </div>
                <div class="more">
                    <a href="<?php echo $linkCat['news']['link']; ?>" target="_blank"><?php echo $linkCat['news']['title']; ?></a>
                </div>
                <div class="contents">
                    <div class="section_icon">
                        <img src="<?php echo $style['news_img']; ?>">
                    </div>
        
                    <div class="items">
                        <?php
                            for($i = 0; $news[$i] != false; $i++)
                            {
                                echo '<span class="date">[' . $news[$i]['date'] . ']</span>';
                                echo '<div class="item"><a href="' . $news[$i]['link'] . '" target="_blank">' . $news[$i]['title'] . '</a></div>';
                            }
                        ?>
                    </div>
                </div>
            </div>
        
            <div style="clear:both">
            </div>
        
            <div class="community">
                <div class="title">
                </div>
                
                <div class="more">
                    <a href="<?php echo $linkCat['comm']['link']; ?>" target="_blank"><?php echo $linkCat['comm']['title']; ?></a>
                </div>
            
                <div class="contents">
                    <div class="section_icon">
                        <img src="<?php echo $style['comm_img']; ?>">
                    </div>
                    <div class="items">
                        <?php
                            for($i = 0; $comm[$i] != false; $i++)
                            {
                                echo '  <span class="date">[' . $comm[$i]['date'] . ']</span>
                                        <div class="item">
                                            <a href="' . $comm[$i]['link'] . '" target="_blank">' . $comm[$i]['title'] . '</a>
                                        </div>';
                            }
                        ?>
                    </div>
                </div>
            </div>
        
            <div style="clear:both">
            </div>
        </div>
        
        <div class="copyright">
            <a href="<?php echo $link['copyright']; ?>" target="_blank"></a>
            <div>
                <?php
                    for($i = 0; $i < 4; $i++) { echo '<div class="shadow' . $i . '">' . $copyright . '</div>'; }
                    echo $copyright;
                ?>
            </div>
        </div>
    </body>
</html>

