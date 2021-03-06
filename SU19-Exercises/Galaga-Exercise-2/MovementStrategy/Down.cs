using DIKUArcade.Entities;
using DIKUArcade.Graphics;
using DIKUArcade.Math;
using Galaga_Exercise_2.GalagaEntities.Enemy;
using Galaga_Exercise_2.Squadrons;

namespace Galaga_Exercise_2.MovementStrategy {
    public class Down : IMovementStrategy {
        public EntityContainer<Enemy> Enemies { get; }

        /*public Down() {
            Enemies = new EntityContainer<Enemy>();
        }*/
        public void MoveEnemy(Enemy enemy) {
            enemy.Shape.MoveY(-0.0003f);
        }

        public void MoveEnemies(EntityContainer<Enemy> enemies) {
            foreach (Enemy enemy in enemies) {
                MoveEnemy(enemy);
            }
        }
    }
}