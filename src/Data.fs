module Data
open Schema
open Schema.DamageShorts
module Nature =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage acid
          Damage physical
          Damage pierce
          Damage bleeding
          Damage cold
          Damage fire
          Damage lightning
          Damage physical
          Damage weapon
          Damage poison
          Damage vitality
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Nature"
    theme=Titan
    skills=[
      notImplemented
    ]
  }
module Spirit =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage aether
          Damage bleeding
          Damage cold
          Damage decay
          Damage fire
          Damage lightning
          Damage physical
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Spirit"
    theme=Titan
    skills=[
      notImplemented
    ]
  }
module Dream =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage chaos
          Damage electrocute
          Damage physical
          Damage trauma
          Damage vitality
          Damage weapon
          DirectConversion {Source = Physical;Target=Vitality}
          DirectConversion {Source = Physical;Target=Elemental Lightning}
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Dream"
    theme=Titan
    skills=[
      notImplemented
    ]
  }
module Storm =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage aether
          Damage cold
          Damage decay
          Damage electrocute
          Damage frostburn
          Damage lightning
          Damage vitality
          // DirectConversion {Source = Physical;Target=Lightning}
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Storm"
    theme=Titan
    skills=[
      notImplemented
    ]
  }

module Earth =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage aether
          // DirectConversion {Source = Physical;Target=Lightning}
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Earth"
    theme=Titan
    skills=[
      notImplemented
    ]
  }
let gdClasses : GdClass list = [
  Classes.Titan.Rogue.cls
  Nature.cls
  Spirit.cls
  Dream.cls
  Storm.cls
]

let allTags =
  gdClasses
  |> List.collect(fun gc ->
    gc.skills
  )
  |> List.collect (fun sk ->
    let modTags =
      sk.mods
      |> List.collect (fun m -> m.tags)
    sk.tags@modTags
  )
  |> List.distinct
let allTagDisplays =
  allTags
  |> List.map (Tag.ToDisplay)
