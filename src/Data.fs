module GrimModTools.Data
open Schema
open Schema.DamageShorts

let gdClasses : GdClass list = [
  Classes.D3.NotImplemented.DemonHunter.cls
  Classes.D3.NotImplemented.WitchDoctor.cls
  Classes.D3.NotImplemented.Monk.cls
  Classes.D3.NotImplemented.Wizard.cls
  Classes.D3.NotImplemented.Crusader.cls
  Classes.D3.NotImplemented.Necromancer.cls
  Classes.D3.NotImplemented.Barbarian.cls

  Classes.Grim.NotImplemented.Soldier.cls
  Classes.Grim.NotImplemented.Demolitionist.cls
  Classes.Grim.NotImplemented.Occultist.cls
  Classes.Grim.NotImplemented.Nightblade.cls
  Classes.Grim.NotImplemented.Arcanist.cls
  Classes.Grim.NotImplemented.Shaman.cls
  Classes.Grim.NotImplemented.Inquisitor.cls
  Classes.Grim.NotImplemented.Necromancer.cls
  Classes.Grim.NotImplemented.Oathkeeper.cls

  Classes.Titan.NotImplemented.Nature.cls
  Classes.Titan.NotImplemented.Spirit.cls
  Classes.Titan.NotImplemented.Dream.cls
  Classes.Titan.NotImplemented.Storm.cls
  Classes.Titan.NotImplemented.Earth.cls
  Classes.Titan.NotImplemented.Defender.cls
  Classes.Titan.NotImplemented.Warfare.cls
  Classes.Titan.Rogue.cls
  Classes.Titan.NotImplemented.Hunting.cls

  Classes.Other.NotImplemented.TerrorKnight.cls
  Classes.Other.NotImplemented.Elementalist.cls
  Classes.Other.NotImplemented.Outrider.cls
  Classes.Other.NotImplemented.Champion.cls
  Classes.Other.NotImplemented.Riftstalker.cls
  Classes.Other.NotImplemented.Necrotic.cls
]

let isDamage = function |Damage _ -> true | _ -> false
let isConversion = function |DirectConversion _ -> true | DoTConversion _ -> true | _ -> false
let getClassTags (cls:GdClass) =
    cls.skills
    |> List.collect (fun sk ->
      let modTags =
        sk.mods
        |> List.collect (fun m -> m.tags)
      sk.tags@modTags
    )
    |> List.filter (isConversion >> not)

let getAllTags classes =
  classes
  |> List.collect getClassTags
  |> List.distinctBy(Tag.ToDisplay)
  |> List.sortBy(fun x ->
    isConversion x, isDamage x, string x
  )
let getTagDisplays = List.map (Tag.ToDisplay)