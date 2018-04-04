public enum AttackTarget{
	PLAYER,
	ENEMY
}

public class AttackAction: BaseAction {
	public AttackTarget target;
	public int power;
	
	public AttackAction(AttackTarget target, int power){
		this.name = "ATTACK";
		this.target = target;
		this.power = power;
	}
}
