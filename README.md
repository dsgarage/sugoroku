# すごろくUnity
すごろく作るぞー！

## SetUp
* StepクラスがついたGameObjectをScene上に配置
* StepCreaterでマス目を生成
* PlayerとするGameObjectには、必ずCinemachineのVertualCameraとPlayerクラスがAddされている


## 2020/11/9
Dice.cs<br>
Step.cs<br>
GameLogic.cs<br>
<br>
・ダイスを振って、PlayerオブジェクトについているStepに何マス目にいるかを更新する<br>
・ターンの管理。<br>
<br>

## 2020/11/16
<br>
PlayerColorManager.cs<br>
StepCreater.cs<br>
GameLogic.cs<br>

<br>
GameLogic.cs<br>
・マス目を大量に作るエディッタ拡張<br>
・プレイヤーの色を変更するマネージャークラス<br>
・進んだマス目のGameObjectの座標に移動するメソッド改修<br>

## 2020/11/30

* Playerクラスを作って、Stepクラスとの責任を分ける
* Playerクラスには、自分が映るVertualCameraと自分の背番号を持たせる
* GameLogicから参照できるように、Stepクラスを参照とるときと同様に処理をする


