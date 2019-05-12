module GrimModTooling.Classes.Titan.NotImplemented
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
          Damage weapon
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
          Damage burn
          Damage chaos
          Damage fire
          Damage physical
          Damage weapon
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
module Defender =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage bleeding
          Damage physical
          Damage trauma
          Damage weapon
          // DirectConversion {Source = Physical;Target=Lightning}
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Defender"
    theme=Titan
    skills=[
      notImplemented
    ]
  }
module Warfare =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage bleeding
          Damage physical
          Damage pierce
          Damage trauma
          Damage weapon
          // DirectConversion {Source = Physical;Target=Lightning}
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Warfare"
    theme=Titan
    skills=[
      notImplemented
    ]
  }
module Hunting =
  let theme = Titan
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage acid
          Damage bleeding
          Damage burn
          Damage cold
          Damage electrocute
          Damage fire
          Damage pierce
          Damage physical
          Damage lightning
          Damage weapon
          // DirectConversion {Source = Physical;Target=Lightning}
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Hunting"
    theme=Titan
    skills=[
      notImplemented
    ]
  }