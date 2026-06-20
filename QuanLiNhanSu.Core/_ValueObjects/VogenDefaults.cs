using Vogen;

[assembly: VogenDefaults(
    conversions: Conversions.SystemTextJson,
    staticAbstractsGeneration: StaticAbstractsGeneration.MostCommon | StaticAbstractsGeneration.InstanceMethodsAndProperties)]
