module Classes.D3.NotImplemented
open Schema
open Schema.DamageShorts
module DemonHunter =
  let theme = D3
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage bleeding
          Damage burn
          Damage cold
          Damage electrocute
          Damage fire
          Damage frostburn
          Damage lightning
          Damage physical
          Damage pierce
        //   Damage trauma
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Demon Hunter"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module WitchDoctor =
  let theme = D3
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
          Damage acid
        //   Damage bleeding
          Damage burn
          Damage cold
          Damage decay
        //   Damage electrocute
          Damage fire
          Damage frostburn
        //   Damage lightning
          Damage physical
          Damage poison
        //   Damage pierce
        //   Damage trauma
          Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Witch Doctor"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Monk =
  let theme = D3
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
        //   Damage acid
        //   Damage bleeding
          Damage burn
          Damage cold
        //   Damage decay
          Damage electrocute
          Damage fire
        //   Damage frostburn
          Damage lightning
          Damage physical
        //   Damage poison
        //   Damage pierce
          Damage trauma
        //   Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Monk"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Wizard =
  let theme = D3
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
        //   Damage acid
        //   Damage bleeding
          Damage burn
          Damage cold
        //   Damage decay
          Damage electrocute
          Damage fire
          Damage frostburn
          Damage lightning
        //   Damage physical
        //   Damage poison
        //   Damage pierce
        //   Damage trauma
        //   Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Monk"
    theme=theme
    skills=[
      notImplemented
    ]
  }
module Crusader =
  let theme = D3
  module Skills =
    let notImplemented =
      {
        name="not implemented"
        usage= Active
        tags = [
        //   Damage acid
        //   Damage bleeding
          Damage burn
        //   Damage cold
        //   Damage decay
          Damage electrocute
          Damage fire
        //   Damage frostburn
          Damage lightning
          Damage physical
        //   Damage poison
        //   Damage pierce
          Damage trauma
        //   Damage vitality
          Damage weapon
        ]
        mods = []
      }
  open Skills
  let cls = {
    name="Crusader"
    theme=theme
    skills=[
      notImplemented
    ]
  }