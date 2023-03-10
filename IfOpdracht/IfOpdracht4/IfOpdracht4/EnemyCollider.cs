using System.ComponentModel.Design;

namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            if (enemy.flying || enemy.incoporial ) return true;
            //gebruik hier een || (OR)
			//je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            return false;//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            if (enemy.swimmer || enemy.subterranian) return true;
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            return false;//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
        }
    }
}