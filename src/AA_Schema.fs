module Schema
type DoT =
  |Bleeding
  |Poison
  |VitalityDecay
  |Burn
  |Frostburn
  |Electrocute
  |InternalTrauma
type Element =
  | Fire
  | Cold
  | Lightning
type DamageType =
  |Aether
  |Acid
  |Chaos
  |Vitality
  |Physical
  |Pierce
  |Percent
  |Elemental of Element
  with
    static member GetDot =
      function
      | Aether -> None
      | Acid -> Some Poison
      | Chaos -> None
      | Physical -> Some InternalTrauma
      | Percent -> None
      | Vitality -> Some VitalityDecay
      | Elemental Fire -> Some Burn
      | Elemental Cold -> Some Frostburn
      | Elemental Lightning -> Some Electrocute
      | Pierce -> None
// https://grimdawn.fandom.com/wiki/Damage_Types
type Damage =
  |Direct of DamageType
  |DoT of DoT
  |Weapon

module DamageShorts =
  let acid = Direct Acid
  let aether = Direct Aether
  let bleeding = DoT Bleeding
  let burn = DoT Burn
  let chaos = Direct Chaos
  let cold = Direct <| Elemental Cold
  let decay = DoT VitalityDecay
  let electrocute = DoT <| Electrocute
  let fire = Direct <| Elemental Fire
  let frostburn = DoT Frostburn
  let lightning = Direct <| Elemental Lightning
  let percent = Direct Percent
  let physical = Direct Physical
  let pierce = Direct Pierce
  let poison = DoT Poison
  let trauma = DoT InternalTrauma
  let vitality = Direct Vitality
  let weapon = Weapon
open DamageShorts

type Conversion<'t> = {Source:'t;Target:'t} with override x.ToString() = sprintf "%A->%A" x.Source x.Target

type Usage =
  | Active
  | Passive
  | Toggle

type Tag =
  |DirectConversion of Conversion<DamageType>
  |DoTConversion of Conversion<DoT>
  // requires shield, 2h, ranged, dual,etc...
  |TagHandRestriction of req:string
  |Damage of Damage
  |Pet
  |DamageToHealth
  |Area
  |Cooldown
  |Duration
  |Usage
  with
    static member ToDisplay =
      function
      | DirectConversion x -> sprintf "%A" x
      | DoTConversion x -> sprintf "%A" x
      | TagHandRestriction x -> sprintf "%A" x
      | Damage (Direct x) -> sprintf "%A" x
      | Damage (DoT x) -> sprintf "%A" x
      | Damage Weapon -> "Weapon"
      | x -> sprintf "%A" x

  // with
  //   override x.ToString() =
  //     match x with
  // //     | Damage (Direct dt) -> string dt
  // //     | Damage (DoT dt) -> string dt
  //     | _ -> System.Object.ToString(x)

type Theme =
  |GD
  |D3
  |Titan
  |Other

type SkillMod = {
  modname:string
  tags:Tag list
  isGlobal:bool
}
type Skill = {
  name: string
  usage: Usage
  tags: Tag list
  mods: SkillMod list
} with
  static member ToTags (x:Skill):Tag list =
    let modTags =
      x.mods
        |> List.map(fun m ->
          if m.isGlobal then m else {m with tags = m.tags |> List.filter(function |DirectConversion _ -> false | DoTConversion _ -> false | _ -> true)})
    x.tags @ (modTags |> List.collect(fun m -> m.tags))

type GdClass = {
  name:string
  theme:Theme
  skills: Skill list
}
  with
    static member HasSkillWithTag (x:GdClass) (tag:Tag) =
      x.skills |> List.exists(Skill.ToTags >> List.exists(fun tg -> tg= tag))