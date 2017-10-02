using EntityComponentSystem.Base;

namespace EntityComponentSystem.Components
{
    class HealthComponent : BaseComponent
    {
        private int health, baseHealth, maxHealth;
        public HealthComponent(int baseHealth, int maxHealth) : base() {
            this.health = baseHealth;
            this.baseHealth = baseHealth;
            this.maxHealth = maxHealth;
        }

		public override bool ConstraintReached(IEntity constraintEntity) {
			if(constraintEntity.HasComponent(this)) {
				return true;
			}
			return false;
		}
	}
}
