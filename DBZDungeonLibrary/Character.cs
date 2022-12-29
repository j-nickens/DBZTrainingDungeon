namespace DBZDungeonLibrary
{
    public abstract class Character
    {

        //Fields - Funny
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        //Properties - People
        public string Name { get { return _name; } set { _name = value; } }
        public int HitChance { get { return _hitChance; } set { _hitChance = value; } }
        public int Block { get { return _block; } set { _block = value; } }
        public int MaxLife { get { return _maxLife; } set { _maxLife = value; } }
        public int Life { get { return _life; } set { _life = value <= MaxLife ? value : MaxLife; } }

        //Constructors - Collect
        public Character(string name, int hitChance, int block, int maxLife)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = maxLife;//default new Character types to have maxLife
        }
        //BOTH a FQ ctor, and an unqualified/default ctor
        public Character()
        {

        }
        //Methods - Monkeys
        public override string ToString()
        {
            return $"----- {Name} -----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }

        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        //an abstruct method MUST be inherited
        public abstract int CalcDamage();
    }
}