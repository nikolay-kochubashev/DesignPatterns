using Attacker;
using Attacker.Strategies;

Hero hero = new Hero("Squidward");

hero.SetWeapon(new Broom());
hero.Attack();

hero.SetWeapon(new Plunger());
hero.Attack();