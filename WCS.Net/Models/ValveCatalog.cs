namespace WCS.Net.Models;

// Real brand copy for Klinger Westad, KSB Amri, PK Valves, and Royal Goodwin. Photos are
// still placeholders for KSB Amri, PK Valves, and Royal Goodwin — swap in real photography
// once it's available. Klinger Westad already carries the real HQ/Acto actuator parts
// photos and the LPG seals callout, since both are specific to that brand.
public static class ValveCatalog
{
    public static readonly IReadOnlyList<ValveViewModel> All = new[]
    {
        new ValveViewModel
        {
            Slug = "klinger-westad",
            Name = "Klinger Westad",
            Kicker = "Service & Spare Parts",
            Teaser = "Full parts and service support for Klinger Westad LNG butterfly valves and actuators — including seals for gate valves the manufacturer no longer makes.",
            MetaTitle = "Klinger Westad Valve Spare Parts & Seals | WCS",
            MetaDescription = "Independent spare parts and service for Klinger Westad LNG valves: metal & PTFE seals, HQ/Acto actuator parts, discontinued gate valve seals. 25% Price Guarantee.",
            ThumbnailSrc = "/images/valves/klinger-westad/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Klinger Westad",
            IntroParagraphs = new[]
            {
                "Klinger Westad LNG butterfly valves are among the most widely used cryogenic valves on LNG carriers worldwide. WCS was the first independent company to give shipowners a genuine alternative for spares and service.",
                "We service and supply the full range of Klinger Westad spare and actuator parts — including HQ limitswitch boxes, Acto distribution bars, and HQ/Acto cylinder seal kits — and carry out service and overhaul both on board and in dock. Our metal seals are manufactured in-house in Norway; we're also the only supplier of seals for older Klinger Westad gate valves the manufacturer no longer produces. Every WCS-manufactured part carries our 25% Price Guarantee against the OEM price.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/parts/hq-limitswitch-before.jpg", Alt = "A worn HQ limitswitch box after years of service", Caption = "HQ LIMITSWITCH BOX — AS RECEIVED" },
                new ValvePhoto { Src = "/images/parts/hq-limitswitch-after.jpg", Alt = "A 316L stainless steel limitswitch box manufactured by WCS", Caption = "316L STAINLESS STEEL LIMITSWITCH BOX — WCS" },
                new ValvePhoto { Src = "/images/parts/acto-distribution-bar-before.jpg", Alt = "A worn Acto distribution bar, corroded", Caption = "ACTO DISTRIBUTION BAR — AS RECEIVED" },
                new ValvePhoto { Src = "/images/parts/acto-distribution-bar-after.jpg", Alt = "A newly machined Acto distribution bar manufactured by WCS", Caption = "ACTO DISTRIBUTION BAR — WCS" },
                new ValvePhoto { Src = "/images/parts/seal-kit-1.jpg", Alt = "HQ and Acto cylinder seal kit, assembled", Caption = "HQ & ACTO CYLINDER SEAL KITS" },
                new ValvePhoto { Src = "/images/parts/seal-kit-2.jpg", Alt = "HQ and Acto cylinder seal kit, alternate", Caption = "HQ 400 CYLINDERS — MORE SIZES IN PROGRESS" },
                new ValvePhoto { Src = "/images/parts/hydraulic-block-blind-plug.jpg", Alt = "HQ hydraulic block blind plug", Caption = "HQ HYDRAULIC BLOCK BLIND PLUG" },
            },
            SealTypes = new[]
            {
                "LNG Metal Seals 150–250 mm",
                "LNG PTFE Seals 150–600 mm",
                "LPG HPBV Seals 150–350 mm",
                "LNG Spares & Actuator Parts",
                "General Consumables - Grafoil Tape, Locking Wire, Molykote, & Lubricants",
            },
            Callout = new ValveCallout
            {
                Kicker = "New",
                Title = "LPG seals, now available from WCS",
                Body = "Following repeated requests from customers, WCS now supplies LPG seals for Klinger Westad " +
                       "valves — designed as a direct, fully compatible OEM replacement. We're building stock of " +
                       "the most common sizes for shorter lead times and fast worldwide delivery. The 25% Price " +
                       "Guarantee applies here too.",
            },
            Faqs = new[]
            {
                new ValveFaq
                {
                    Question = "Is WCS an authorized Klinger Westad dealer?",
                    Answer = "No — WCS is an independent supplier, not affiliated with Klinger Westad. Our parts are manufactured to the same specification as the OEM part and designed as direct, fully compatible replacements, backed by our 25% Price Guarantee against the OEM price.",
                },
                new ValveFaq
                {
                    Question = "Can I still get seals for older Klinger Westad gate valves?",
                    Answer = "Yes. Klinger Westad no longer produces seals for its older gate valves, but WCS manufactures and supplies them in-house in Norway — we're currently the only supplier able to do so.",
                },
                new ValveFaq
                {
                    Question = "What Klinger Westad parts does WCS supply?",
                    Answer = "LNG metal and PTFE seals, LPG HPBV seals, HQ limitswitch boxes, Acto distribution bars, and HQ/Acto cylinder seal kits, plus general consumables such as Grafoil tape and Molykote.",
                },
                new ValveFaq
                {
                    Question = "Can Klinger Westad valves be serviced on board?",
                    Answer = "Yes, WCS carries out service and overhaul on Klinger Westad valves and actuators both on board and in dock.",
                },
            },
            CaseStudies = new[]
            {
                new ValveCaseStudy
                {
                    Title = "HQ Limitswitch Box: Worn Original to 316L Stainless Rebuild",
                    Paragraphs = new[]
                    {
                        "The HQ limitswitch box pictured above came in after years of service in the marine cryogenic environment — worn to the point where the original was no longer fit to remain in service.",
                        "WCS reverse-engineered the part to the original dimensions and manufactured a direct replacement in-house in Norway, in 316L stainless steel — an upgrade in corrosion resistance over the original material, while keeping it a drop-in fit for the existing HQ actuator. The rebuilt box is covered by the same 25% Price Guarantee as the rest of our Klinger Westad range.",
                    },
                },
                new ValveCaseStudy
                {
                    Title = "Acto Distribution Bar: Corroded Original to Newly Machined Replacement",
                    Paragraphs = new[]
                    {
                        "The Acto distribution bar shown above was corroded after years in service — a common failure point on older actuators.",
                        "WCS machined a replacement in-house in Norway to the original specification, restoring a fully compatible, drop-in part without waiting on OEM lead times.",
                    },
                },
            },
            History = "Klinger Westad traces back to 1895, when Daniel Westad founded a valve manufacturing company in Geithus, Norway, originally serving the local pulp and paper industry. The company moved into marine applications around 1950, began building valves for LNG in the 1960s, and produced its first LNG butterfly valve in 1975 — pioneering the cryogenic butterfly valve technology still used across the industry today. Klinger Westad remains headquartered in Geithus and is now part of the international KLINGER Group.",
        },
        new ValveViewModel
        {
            Slug = "ksb-amri",
            Name = "KSB Amri",
            Kicker = "Service & Spare Parts",
            Teaser = "Independent parts and service for KSB Amri LNG butterfly valves and actuators, including HQ actuator cylinders and Danais-size metal seals.",
            MetaTitle = "KSB Amri Valve Spare Parts & Seals | WCS",
            MetaDescription = "Independent spare parts and service for KSB Amri LNG valves: Danais-size metal seals, actuator parts, flange gaskets, HQ cylinders. 25% Price Guarantee.",
            ThumbnailSrc = "/images/valves/ksb-amri/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for KSB Amri",
            IntroParagraphs = new[]
            {
                "KSB Amri LNG butterfly valves use the same metal-to-metal sealing technology as Klinger Westad.",
                "We service and supply spare parts, actuator parts, flange gaskets, and HQ actuator cylinders for KSB Amri equipment, with service on board or in dock. Metal seals, including the larger Danais-size range, are manufactured in-house in Norway, backed by our 25% Price Guarantee against the OEM price.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-1.svg", Alt = "Placeholder photo of KSB Amri valve, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-2.svg", Alt = "Placeholder photo of KSB Amri valve, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-3.svg", Alt = "Placeholder photo of KSB Amri valve, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-4.svg", Alt = "Placeholder photo of KSB Amri valve, 4 of 4" },
            },
            SealTypes = new[]
            {
                "LNG Metal Seals (Danais) 300–500 mm",
                "LNG Spares, Gaskets & Actuator Parts",
                "HQ Actuator Cylinders",
                "General Consumables - Grafoil Tape, Locking Wire, Molykote, & Lubricants",
            },
            Faqs = new[]
            {
                new ValveFaq
                {
                    Question = "Is WCS an authorized KSB Amri dealer?",
                    Answer = "No — WCS is an independent supplier, not affiliated with KSB Amri. Our parts are designed as direct OEM-compatible replacements and carry our 25% Price Guarantee against the OEM price.",
                },
                new ValveFaq
                {
                    Question = "What KSB Amri parts does WCS supply?",
                    Answer = "Spare parts, actuator parts, flange gaskets, HQ actuator cylinders, and metal seals including the larger Danais-size range — all manufactured in-house in Norway.",
                },
                new ValveFaq
                {
                    Question = "Do KSB Amri valves use the same sealing technology as Klinger Westad?",
                    Answer = "Yes — KSB Amri LNG butterfly valves use the same metal-to-metal sealing technology as Klinger Westad, which is why WCS applies the same in-house manufacturing process to both.",
                },
                new ValveFaq
                {
                    Question = "Can KSB Amri valves be serviced on board?",
                    Answer = "Yes, service is available both on board and in dock.",
                },
            },
            History = "The AMRI brand traces back to 1959, when a French manufacturer built what became the world's second-largest butterfly valve producer, based in La Roche-Chalais with a research centre near Bordeaux. German pump and valve group KSB acquired AMRI in 1989, making KSB the world leader in cryogenic valves and the French leader in butterfly valves. The AMRI name has continued to change hands since — its North American operations were acquired by Bray International in 2016 and now trade as Amresist — a reminder of how much this market has consolidated around a small number of OEMs.",
        },
        new ValveViewModel
        {
            Slug = "pk-valves",
            Name = "PK Valves",
            Kicker = "Service & Spare Parts",
            Teaser = "WCS now supplies metal-to-metal seals for PK Valves — the newest addition to our LNG butterfly valve aftermarket range.",
            MetaTitle = "PK Valves Spare Parts & Metal Seals | WCS",
            MetaDescription = "Metal-to-metal seals and spare parts for PK Valves LNG butterfly valves, 400-550mm, from an independent supplier. 25% Price Guarantee vs. OEM pricing.",
            ThumbnailSrc = "/images/valves/pk-valves/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for PK Valves",
            IntroParagraphs = new[]
            {
                "PK Valves use the same metal-to-metal sealing technology found in Klinger Westad and KSB Amri LNG butterfly valves. WCS is now entering the market for PK valve seals as well.",
                "This is our newest valve line — we're building out parts and service coverage starting with metal seals in the 400–550 mm range, with more sizes to follow. Contact us to check availability for your specific valve.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-1.svg", Alt = "Placeholder photo of PK Valves valve, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-2.svg", Alt = "Placeholder photo of PK Valves valve, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-3.svg", Alt = "Placeholder photo of PK Valves valve, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-4.svg", Alt = "Placeholder photo of PK Valves valve, 4 of 4" },
            },
            SealTypes = new[]
            {
                "LNG Metal Seals 400–550 mm",
                "General Consumables - Grafoil Tape, Locking Wire, Molykote, & Lubricants",
            },
            Faqs = new[]
            {
                new ValveFaq
                {
                    Question = "Does WCS supply spare parts for PK Valves?",
                    Answer = "Yes — PK Valves is the newest addition to WCS's LNG butterfly valve range. We currently supply metal-to-metal seals in the 400–550mm range, with more sizes in progress.",
                },
                new ValveFaq
                {
                    Question = "Is WCS an authorized PK Valves dealer?",
                    Answer = "No — WCS is an independent supplier, not affiliated with PK Valves. Contact us to check current availability for your specific valve size.",
                },
                new ValveFaq
                {
                    Question = "What sealing technology do PK Valves use?",
                    Answer = "PK Valves use the same metal-to-metal sealing technology found in Klinger Westad and KSB Amri LNG butterfly valves.",
                },
            },
            History = "PK Valve was established in Changwon, South Korea, in 1946, and became the first company to move into the newly created Changwon National Industrial Complex in 1974. Over more than seven decades it grew into one of Korea's leading industrial valve manufacturers, developing cryogenic and butterfly valve lines used in LNG, petrochemical, and power-generation applications in more than 70 countries. Its metal-to-metal sealing butterfly valves use the same underlying technology as Klinger Westad and KSB Amri, which is why WCS has been able to extend its in-house seal manufacturing to cover PK Valves as well.",
        },
        new ValveViewModel
        {
            Slug = "royal-goodwin",
            Name = "Royal Goodwin",
            Kicker = "Service & Spare Parts",
            Teaser = "The only independent supplier of seals for legacy Royal Goodwin LNG valves no longer supported by the manufacturer.",
            MetaTitle = "Royal Goodwin Valve Seals & Spare Parts | WCS",
            MetaDescription = "The only independent supplier of seals for legacy Royal Goodwin LNG valves the manufacturer no longer produces. 25% Price Guarantee vs. OEM.",
            ThumbnailSrc = "/images/valves/royal-goodwin/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Royal Goodwin",
            IntroParagraphs = new[]
            {
                "Royal Goodwin LNG valves are still in service on many older LNG carriers, but Royal Goodwin no longer produces seals for them — leaving shipowners with few options for keeping this equipment running.",
                "WCS is the only supplier able to manufacture and supply seals for older Royal Goodwin valves, with the same 25% Price Guarantee we offer across our full range.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-1.svg", Alt = "Placeholder photo of Royal Goodwin valve, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-2.svg", Alt = "Placeholder photo of Royal Goodwin valve, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-3.svg", Alt = "Placeholder photo of Royal Goodwin valve, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-4.svg", Alt = "Placeholder photo of Royal Goodwin valve, 4 of 4" },
            },
            SealTypes = new[]
            {
                "LNG Seals 250–400 mm",
                "General Consumables - Grafoil Tape, Locking Wire, Molykote, & Lubricants",
            },
            Faqs = new[]
            {
                new ValveFaq
                {
                    Question = "Is Royal Goodwin still making seals for these valves?",
                    Answer = "No — Royal Goodwin no longer produces seals for its older LNG valves. WCS is the only supplier able to manufacture and supply replacement seals for this equipment.",
                },
                new ValveFaq
                {
                    Question = "Is WCS an authorized Royal Goodwin dealer?",
                    Answer = "No — WCS is an independent supplier, not affiliated with Royal Goodwin. We manufacture replacement seals in-house and back them with our 25% Price Guarantee against the OEM price.",
                },
                new ValveFaq
                {
                    Question = "What sizes are available?",
                    Answer = "We currently supply LNG seals in the 250–400mm range for Royal Goodwin valves.",
                },
            },
        },
        new ValveViewModel
        {
            Slug = "danfoss",
            Name = "Danfoss",
            Kicker = "Service & Spare Parts",
            Teaser = "Actuator seal kits for Danfoss actuators fitted to LNG and LPG butterfly valves — typically 20–40% below OEM pricing.",
            MetaTitle = "Danfoss Actuator Seal Kits & Spare Parts | WCS",
            MetaDescription = "Drop-in replacement seal kits for Danfoss actuators on LNG/LPG butterfly valves, built to OEM spec at 20-40% below OEM pricing.",
            ThumbnailSrc = "/images/valves/danfoss/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Danfoss",
            IntroParagraphs = new[]
            {
                "Danfoss actuators are fitted to many of the LNG and LPG butterfly valves WCS already services, and their original seal kits are frequently affected by long OEM lead times and high pricing.",
                "WCS supplies drop-in replacement seal kits for Danfoss actuators, manufactured to the same specification as the OEM part, typically 20–40% below OEM pricing — with our 25% Price Guarantee available on request.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/danfoss/photo-1.svg", Alt = "Placeholder photo of Danfoss actuator, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/danfoss/photo-2.svg", Alt = "Placeholder photo of Danfoss actuator, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/danfoss/photo-3.svg", Alt = "Placeholder photo of Danfoss actuator, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/danfoss/photo-4.svg", Alt = "Placeholder photo of Danfoss actuator, 4 of 4" },
            },
            SealTypes = new[]
            {
                "Danfoss Actuator Seal Kits",
                "General Consumables - Grafoil Tape, Locking Wire, Molykote, & Lubricants",
            },
            Faqs = new[]
            {
                new ValveFaq
                {
                    Question = "Are WCS Danfoss actuator seal kits genuine OEM parts?",
                    Answer = "No — WCS is an independent supplier, not affiliated with Danfoss. Our seal kits are manufactured to the same specification as the OEM part and installed as a drop-in replacement.",
                },
                new ValveFaq
                {
                    Question = "How much cheaper are WCS Danfoss seal kits than OEM?",
                    Answer = "Typically 20–40% below OEM pricing, with our 25% Price Guarantee available on request.",
                },
                new ValveFaq
                {
                    Question = "Which valves are these Danfoss actuator seal kits for?",
                    Answer = "Danfoss actuators are fitted to many of the LNG and LPG butterfly valves WCS already services, so if you have a Danfoss-actuated valve on board, we likely already support it.",
                },
                new ValveFaq
                {
                    Question = "Why buy Danfoss seal kits from WCS instead of Danfoss directly?",
                    Answer = "Original Danfoss seal kits are frequently affected by long OEM lead times and high pricing — WCS supplies drop-in replacements typically 20–40% below OEM cost without the wait.",
                },
            },
            History = "Danfoss was founded on 1 September 1933, when Mads Clausen began building refrigeration valves in his parents' farmhouse in Nordborg, Denmark — originally under the name Dansk Køleautomatik- og Apparatfabrik, renamed Danfoss in 1946. What started as one person's workshop grew into one of Denmark's largest industrial groups, spanning heating, cooling, drives, and power solutions worldwide. Danfoss doesn't manufacture the LNG and LPG butterfly valves WCS services — its actuators are fitted to valves from several manufacturers, which is why original Danfoss actuator seal kits are a recurring spare-parts need across the fleet.",
        },
    };

    public static ValveViewModel? FindBySlug(string slug) =>
        All.FirstOrDefault(v => string.Equals(v.Slug, slug, StringComparison.OrdinalIgnoreCase));

    /// <summary>All valve types other than the given slug — used for "other valve types" cards.</summary>
    public static IEnumerable<ValveViewModel> AllExcept(string slug) =>
        All.Where(v => !string.Equals(v.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
