var tom,tomImage,jerry,jerryImage;
var garden,gardenImage;

function preload() {
    //load the images here
    tomImage=loadImage("tomOne.png","tomTwo.png","tomThree.png","tomFour.png");
    jerryImage=loadImage("jerryOne.png","jerryTwo,png","jerryThree.png","jerryFour.png");
    gardenImage=loadImage("garden.png");
}

function setup(){
    createCanvas(1000,800);
    //create tom and jerry sprites here
    tom=createSprite(80,400,10,20);
    tom.addImage(tomImage); 
    jerry=createSprite(60,300,10,20);
    jerry.addImage(jerryImage);
    garden=createSprite(1000,800);
    garden.addImage(gardenImage);
}

function draw(){
background(255);
//Write condition here to evalute if tom and jerry collide
if(tom.x - jerry.x<(tom.width - jerry.width)/2){
    tom.addAnimation("tomLastImage", tomThree.png);
    tom.changeAnimation("tomLastImage");}
    drawSprites();
    text(jerryX + ',' + jerryY, 10, 45);
}
function keyPressed(){
    if(keyCode === LEFT_ARROW){
     tom.velocityX = -5;
     tom.addAnimation("tomRunning", tomTwo.png);
     tom.changeAnimation("tomRunning");
 }   
}
