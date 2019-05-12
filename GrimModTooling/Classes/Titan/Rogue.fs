module GrimModTooling.Classes.Titan.Rogue
open Schema
open Schema.DamageShorts
let theme = Titan
module Skills =
    let calculatedStrike =
      {
        name= "Calculated Strike"
        usage= Active
        tags= [
          Damage Weapon
          Damage acid
          Damage bleeding
        ]
        mods= [
          {
            modname="Misery"
            isGlobal=false
            tags=[
              DirectConversion {
                Source= Physical
                Target= Vitality
              }
              DirectConversion {
                Source= Pierce
                Target= Acid
              }
            ]
          }
          {
            modname="Killer Instinct"
            isGlobal=true
            tags=[
              Damage pierce
              Damage bleeding
            ]
          }
        ]
      }
    let lethalStrike =
      {
        name="Lethal Strike"
        usage=Passive
        tags=[
              Damage pierce
              Damage bleeding
        ]
        mods=[
          {modname="Caustic Acid";isGlobal=false;tags=[]}
          {modname="Dark Vapors";isGlobal=false;tags=[Damage decay]}

        ]
      }
    let layTrap =
      {
        name="Lay Trap"
        usage=Active
        tags=[
          Damage physical
          Damage pierce
        ]
        mods = [

        ]
      }
    let netherStrike =
      {
        name="Nether Strike"
        usage=Active
        tags=[
          Damage bleeding
          Damage pierce
          Damage vitality
        ]
        mods=[
          {modname="Nether Burst";isGlobal=false;tags=[Damage weapon;Damage poison;Damage decay]}

        ]
      }
open Skills
let cls = {
    name="Rogue"
    theme=Titan
    skills= [
      calculatedStrike
      lethalStrike
      layTrap
      netherStrike
    ]
}